﻿// 
//  IArray.cs
// 
//  Copyright (c) 2017 Couchbase, Inc All rights reserved.
// 
//  Licensed under the Apache License, Version 2.0 (the "License");
//  you may not use this file except in compliance with the License.
//  You may obtain a copy of the License at
// 
//  http://www.apache.org/licenses/LICENSE-2.0
// 
//  Unless required by applicable law or agreed to in writing, software
//  distributed under the License is distributed on an "AS IS" BASIS,
//  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//  See the License for the specific language governing permissions and
//  limitations under the License.
// 

using System;
using System.Collections.Generic;

using JetBrains.Annotations;
using Newtonsoft.Json;

namespace Couchbase.Lite
{
    /// <summary>
    /// An interface representing a read-only linear collection of objects
    /// </summary>
    [JsonConverter(typeof(IArrayConverter))]
    public interface IArray : IArrayFragment, IEnumerable<object>
    {
        #region Properties

        /// <summary>
        /// Gets the number of elements in this array
        /// </summary>
        int Count { get; }

        #endregion

        #region Public Methods

        /// <summary>
        /// Gets the value at the given index as a read only array
        /// </summary>
        /// <param name="index">The index to lookup</param>
        /// <returns>The value at the index, or <c>null</c></returns>
        [CanBeNull]
        ArrayObject GetArray(int index);

        /// <summary>
        /// Gets the value at the given index as a <see cref="Blob"/>
        /// </summary>
        /// <param name="index">The index to lookup</param>
        /// <returns>The value at the index, or <c>null</c></returns>
        [CanBeNull]
        Blob GetBlob(int index);

        /// <summary>
        /// Gets the value at the given index as a <see cref="bool"/>
        /// </summary>
        /// <param name="index">The index to lookup</param>
        /// <returns>The value at the index, or its converted equivalent</returns>
        /// <remarks>Any non-zero object will be treated as true, so don't rely on 
        /// any sort of parsing</remarks>
        bool GetBoolean(int index);

        /// <summary>
        /// Gets the value at the given index as a <see cref="DateTimeOffset"/>
        /// </summary>
        /// <param name="index">The index to lookup</param>
        /// <returns>The value at the index, or a default</returns>
        DateTimeOffset GetDate(int index);

        /// <summary>
        /// Gets the value at the given index as a <see cref="DictionaryObject"/>
        /// </summary>
        /// <param name="index">The index to lookup</param>
        /// <returns>The value at the index, or <c>null</c></returns>
        [CanBeNull]
        DictionaryObject GetDictionary(int index);

        /// <summary>
        /// Gets the value at the given index as a <see cref="Double"/>
        /// </summary>
        /// <param name="index">The index to lookup</param>
        /// <returns>The value at the index, or its converted equivalent</returns>
        /// <remarks><c>true</c> will be converted to 1.0, and everything else that
        /// is non-numeric will be 0.0</remarks>
        double GetDouble(int index);

        /// <summary>
        /// Gets the value at the given index as a <see cref="Single"/>
        /// </summary>
        /// <param name="index">The index to lookup</param>
        /// <returns>The value at the index, or its converted equivalent</returns>
        /// <remarks><c>true</c> will be converted to 1.0f, and everything else that
        /// is non-numeric will be 0.0f</remarks>
        float GetFloat(int index);

        /// <summary>
        /// Gets the value at the given index as an <see cref="Int32"/>
        /// </summary>
        /// <param name="index">The index to lookup</param>
        /// <returns>The value at the index, or its converted equivalent</returns>
        /// <remarks><c>true</c> will be converted to 1, a <see cref="Double"/> value
        /// will be rounded, and everything else non-numeric will be 0</remarks>
        int GetInt(int index);

        /// <summary>
        /// Gets the value at the given index as an <see cref="Int64"/>
        /// </summary>
        /// <param name="index">The index to lookup</param>
        /// <returns>The value at the index, or its converted equivalent</returns>
        /// <remarks><c>true</c> will be converted to 1, a <see cref="Double"/> value
        /// will be rounded, and everything else non-numeric will be 0</remarks>
        long GetLong(int index);

        /// <summary>
        /// Gets the value at the given index as a <see cref="String"/>
        /// </summary>
        /// <param name="index">The index to lookup</param>
        /// <returns>The value at the index, or <c>null</c></returns>
        [CanBeNull]
        string GetString(int index);

        /// <summary>
        /// Gets the value at the given index as an untyped object
        /// </summary>
        /// <param name="index">The index to lookup</param>
        /// <returns>The value at the index, or <c>null</c></returns>
        /// <remarks>This method should be avoided for numeric types, whose
        /// underlying representation is subject to change and thus
        /// <see cref="InvalidCastException"/>s </remarks>
        [CanBeNull]
        object GetValue(int index);

        /// <summary>
        /// Converts the contents of the array to a .NET list type
        /// </summary>
        /// <returns>The contents of the array as a .NET list</returns>
        List<object> ToList();

        #endregion
    }
}
