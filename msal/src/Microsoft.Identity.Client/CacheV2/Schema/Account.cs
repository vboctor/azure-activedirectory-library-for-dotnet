﻿// ------------------------------------------------------------------------------
// 
// Copyright (c) Microsoft Corporation.
// All rights reserved.
// 
// This code is licensed under the MIT License.
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files(the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and / or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions :
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
// 
// ------------------------------------------------------------------------------

namespace Microsoft.Identity.Client.CacheV2.Schema
{
    internal enum AuthorityType
    {
        MsSts,
        Adfs,
        Msa,
        Other
    }

    internal class Account
    {
        public string HomeAccountId { get; set; }
        public string Environment { get; set; }
        public string Realm { get; set; }
        public string LocalAccountId { get; set; }
        public AuthorityType AuthorityType { get; set; }
        public string Username { get; set; }
        public string GivenName { get; set; }
        public string FamilyName { get; set; }
        public string MiddleName { get; set; }
        public string Name { get; set; }
        public string AlternativeAccountId { get; set; }
        public string ClientInfo { get; set; }
        public string AdditionalFieldsJson { get; set; }

        public static Account CreateEmpty()
        {
            return new Account();
        }

        public static Account Create(
            string homeAccountId,
            string environment,
            string realm,
            string localAccountId,
            AuthorityType authorityType,
            string userName,
            string givenName,
            string familyName,
            string middleName,
            string name,
            string alternativeAccountId,
            string clientInfo,
            string additionalFieldsJson)
        {
            return new Account
            {
                HomeAccountId = homeAccountId,
                Environment = environment,
                Realm = realm,
                LocalAccountId = localAccountId,
                AuthorityType = authorityType,
                Username = userName,
                GivenName = givenName,
                FamilyName = familyName,
                MiddleName = middleName,
                Name = name,
                AlternativeAccountId = alternativeAccountId,
                ClientInfo = clientInfo,
                AdditionalFieldsJson = additionalFieldsJson
            };
        }
    }
}