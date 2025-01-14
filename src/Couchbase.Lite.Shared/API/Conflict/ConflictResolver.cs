﻿// 
//  ConflictResolver.cs
// 
//  Copyright (c) 2019 Couchbase, Inc All rights reserved.
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

using JetBrains.Annotations;

namespace Couchbase.Lite
{
    /// <summary>
    /// ConflictResolver provides access to the default conflict resolver used by the replicator.
    /// </summary>
    public static class ConflictResolver
    {
        /// <summary>
        /// Access IConflictResolver.Default to get the singleton DefaultConflictResolver object.
        /// Then call methods on that instance.
        /// </summary>
        [NotNull]
        public static IConflictResolver Default { get; } = new DefaultConflictResolver();
    }
}
