﻿namespace Mind_AM.Infrastructure
{
    public class MindstormMessage
    {
        public MindstormMessage(int size)
        {
            Payload = new byte[size];
        }

        public byte[] Payload { set; get; }
    }
}