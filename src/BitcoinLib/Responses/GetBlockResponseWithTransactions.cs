// Copyright (c) 2014 - 2016 George Kimionis
// See the accompanying file LICENSE for the Software License Aggrement

using System.Collections.Generic;

namespace BitcoinLib.Responses
{
    public class GetBlockResponseWithTransactions : GetBlockResponse
    {
        public GetBlockResponseWithTransactions()
        {
            TX = new List<GetRawTransactionResponse>();
        }

        public List<GetRawTransactionResponse> TX { get; set; }
    }
}