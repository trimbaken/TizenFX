/*
* Copyright (c) 2016 Samsung Electronics Co., Ltd All Rights Reserved
*
* Licensed under the Apache License, Version 2.0 (the License);
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
* http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an AS IS BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*/


using System;

namespace Tizen.Multimedia.MediaController
{

	/// <summary>
	/// CustomCommandRecieved event arguments
	/// </summary>
	/// <remarks>
	/// CustomCommandRecieved event arguments
	/// </remarks>
	public class CommandReplyEventArgs : EventArgs
	{
		internal string _serverName;
		internal int _result;
		internal IntPtr _bundle;
		internal IntPtr _userData;

		public CommandReplyEventArgs (string serverName, int result, IntPtr bundle, IntPtr userData)
		{
			_serverName = serverName;
			_result = result;
			_bundle = bundle;
			_userData = userData;
		}

		/// <summary>
		/// Get server name.
		/// </summary>
		/// <value> 0 - 100 </value>
		public string ServerName
		{
			get
			{
				return _serverName;
			}
		}

		/// <summary>
		/// Get playback information.
		/// </summary>
		/// <value> 0 - 100 </value>
		public int Result
		{
			get
			{
				return _result;
			}
		}

		/// <summary>
		/// Get bundle data.
		/// </summary>
		/// <value> 0 - 100 </value>
		public IntPtr BundleData
		{
			get
			{
				return _bundle;
			}
		}

		/// <summary>
		/// Get user data.
		/// </summary>
		/// <value> 0 - 100 </value>
		public IntPtr UserData
		{
			get
			{
				return _userData;
			}
		}
	}
}

