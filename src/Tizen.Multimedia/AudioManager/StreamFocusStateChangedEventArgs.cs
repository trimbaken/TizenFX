﻿ /*
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

namespace Tizen.Multimedia
{
    /// <summary>
    /// Class extending EventArgs and contains the necessary parameters to passed to FocusStateChanged event handler
    /// </summary>
    public class StreamFocusStateChangedEventArgs : EventArgs
    {
        private AudioStreamFocusChangedReason _reason;
        private string _extraInformation;

        internal StreamFocusStateChangedEventArgs(AudioStreamFocusChangedReason reason, string extraInformation)
        {
            _reason = reason;
            _extraInformation = extraInformation;
        }

        /// <summary>
        /// The reason for state change of the focus
        /// </summary>
        public AudioStreamFocusChangedReason FocusChangedReason 
        {
            get
            {
                return _reason;
            }
        }

        /// <summary>
        /// The extra information
        /// </summary>
        public string ExtraInfoformation
        {
            get
            {
                return _extraInformation;
            }
        }
    }
}