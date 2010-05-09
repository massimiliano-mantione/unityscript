﻿#region license
// Copyright (c) 2003, 2004, 2005 Rodrigo B. de Oliveira (rbo@acm.org)
// All rights reserved.
// 
// Redistribution and use in source and binary forms, with or without modification,
// are permitted provided that the following conditions are met:
// 
//     * Redistributions of source code must retain the above copyright notice,
//     this list of conditions and the following disclaimer.
//     * Redistributions in binary form must reproduce the above copyright notice,
//     this list of conditions and the following disclaimer in the documentation
//     and/or other materials provided with the distribution.
//     * Neither the name of Rodrigo B. de Oliveira nor the names of its
//     contributors may be used to endorse or promote products derived from this
//     software without specific prior written permission.
// 
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND
// ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED
// WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE
// DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT OWNER OR CONTRIBUTORS BE LIABLE
// FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL
// DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR
// SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER
// CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY,
// OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF
// THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
#endregion

using System.Collections;

namespace Boo.Lang.Runtime
{
	public delegate object Dispatcher(object target, object[] args);
	public delegate Dispatcher DispatcherFactory();

	public class DispatcherCache
	{
		private static Hashtable _cache = new Hashtable();

		/// <summary>
		/// Gets a dispatcher from the cache if available otherwise
		/// invokes factory to produce one and then cache it.
		/// </summary>
		/// <param name="key">the dispatcher key</param>
		/// <param name="factory">function to produce a dispatcher in case one it's not yet available</param>
		/// <returns></returns>
		public Dispatcher Get(DispatcherKey key, DispatcherFactory factory)
		{
			lock (_cache)
			{
				Dispatcher dispatcher = (Dispatcher) _cache[key];
				if (null == dispatcher)
				{
					dispatcher = factory();
					_cache.Add(key, dispatcher);
				}
				return dispatcher;
			}
		}

		/// <summary>
		/// Removes all Dispatchers from the cache.
		/// </summary>
		public void Clear()
		{
			lock (_cache)
			{
				_cache.Clear();
			}
		}
	}
}
