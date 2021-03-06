﻿/*
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
using System.Runtime.InteropServices;

namespace Tizen.Applications
{
    internal sealed class SafeWatchTimeHandle : SafeHandle
    {
        internal SafeWatchTimeHandle() : base(IntPtr.Zero, true)
        {
        }

        internal SafeWatchTimeHandle(IntPtr existingHandle, bool ownHandle) : base(IntPtr.Zero, ownHandle)
        {
            SetHandle(existingHandle);
        }

        public override bool IsInvalid
        {
            get { return this.handle == IntPtr.Zero; }
        }

        protected override bool ReleaseHandle()
        {
            Interop.Watch.WatchTimeDelete(this.handle);
            this.SetHandle(IntPtr.Zero);
            return true;
        }
    }
}