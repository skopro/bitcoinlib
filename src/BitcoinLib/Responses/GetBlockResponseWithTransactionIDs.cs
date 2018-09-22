// Copyright (c) 2014 - 2016 George Kimionis
// See the accompanying file LICENSE for the Software License Aggrement

using System.Collections.Generic;

namespace BitcoinLib.Responses
{
    public class GetBlockResponseWithTransactionIDs : GetBlockResponse
    {
        public GetBlockResponseWithTransactionIDs()
        {
            TX = new List<string>();
        }

        public List<string> TX { get; set; }
    }
}