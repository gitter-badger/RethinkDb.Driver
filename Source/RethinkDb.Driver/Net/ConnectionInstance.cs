using System;
using System.Collections.Generic;
using System.Linq;
using RethinkDb.Driver.Ast;

namespace RethinkDb.Driver.Net
{
    public class ConnectionInstance
    {
        internal SocketWrapper Socket { get; private set; }

        private readonly Dictionary<long, ICursor> cursorCache = new Dictionary<long, ICursor>();
        private bool closing = false;

        public virtual void Connect(string hostname, int port, byte[] handshake, TimeSpan? timeout)
        {
            var sock = new SocketWrapper(hostname, port, timeout);
            sock.Connect(handshake);
            Socket = sock;
        }

        public virtual bool Open
        {
            get { return Socket?.Open ?? false; }
        }

        public virtual void Close()
        {
            closing = true;
            foreach( var cursor in cursorCache.Values.ToList() )
            {
                cursor.SetError("Connection is closed.");
            }
            cursorCache.Clear();
            Socket?.Close();
        }

        internal virtual void AddToCache(long token, ICursor cursor)
        {
            cursorCache[token] = cursor;
        }

        internal virtual void RemoveFromCache(long token)
        {
            cursorCache.Remove(token);
        }

        internal virtual Response ReadResponse(Query query)
        {
            return ReadResponse(query, null);
        }

        internal virtual Response ReadResponse(Query query, long? deadline)
        {
            if( Socket == null )
                throw new ReqlError("Socket not open");

            long token = query.Token;

            while( true )
            {
                //may or maynot be the token we're looking for.
                var res = this.Socket.Read();

                ICursor cursor;
                if( cursorCache.TryGetValue(res.Token, out cursor) )
                {
                    cursor.Extend(res);
                    if( res.Token == token )
                    {
                        return null;
                    }
                }
                else if( res.Token == token )
                {
                    return res;
                }
                else if( !closing )
                {
                    Close();
                    throw new ReqlDriverError($"Unexpected response received: {res}");
                }
            }
        }
    }
}