// Copyright (c) 2014 - 2016 George Kimionis
// See the accompanying file LICENSE for the Software License Aggrement


namespace BitcoinLib.Responses
{
    public class GetBlockResponse
    {
        public string Hash { get; set; }
        public long Confirmations { get; set; }
        public long Size { get; set; }
        public long StrippedSize { get; set; }
        public long Weight { get; set; }
        public long Height { get; set; }
        public long Version { get; set; }
        public string VersionHex { get; set; }
        public string MerkleRoot { get; set; }
        public double Difficulty { get; set; }
        public string ChainWork { get; set; }
        public string PreviousBlockHash { get; set; }
        public string NextBlockHash { get; set; }
        public string Bits { get; set; }
        public long Time { get; set; }
        public long MedianTime { get; set; }
        public long Nonce { get; set; }
    }
}