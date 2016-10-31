using System;
using System.Net.Sockets;

namespace Novell.Directory.Ldap.NETStandard
{
	public class TcpClientWithDispose : TcpClient
	{
		public TcpClientWithDispose ()
		{
		}

		public void Dispose ()
		{
			base.Dispose (true);
			GC.SuppressFinalize (this);
		}
	}
}

