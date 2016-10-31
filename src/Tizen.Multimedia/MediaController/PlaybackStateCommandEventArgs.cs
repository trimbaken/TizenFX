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
	/// PlaybackStateCommand event arguments
	/// </summary>
	/// <remarks>
	/// PlaybackStateCommand event arguments
	/// </remarks>
	public class PlaybackStateCommandEventArgs : EventArgs
	{
		internal string _clientName;
		internal PlaybackState _state;
		internal IntPtr _userData;

		public PlaybackStateCommandEventArgs (string name, PlaybackState state, IntPtr userData)
		{
			_clientName = name;
			_state = state;
			_userData = userData;
		}

		/// <summary>
		/// Get client name.
		/// </summary>
		/// <value> 0 - 100 </value>
		public string ClientName
		{
			get
			{
				return _clientName;
			}
		}

		/// <summary>
		/// Get playback state.
		/// </summary>
		/// <value> 0 - 100 </value>
		public PlaybackState State
		{
			get
			{
				return _state;
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

