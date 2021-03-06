﻿using AustinHarris.JsonRpc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestServer_Console
{
    public class CalculatorService : JsonRpcService
    {
        [JsonRpcMethod]
        private double add(double l, double r)
        {
            return l + r;
        }

        [JsonRpcMethod]
        private int addInt(int l, int r)
        {
            return l + r;
        }

        [JsonRpcMethod]
        public float? NullableFloatToNullableFloat(float? a)
        {
            return a;
        }

        [JsonRpcMethod]
        public decimal? Test2(decimal x)
        {
            return x;
        }

        [JsonRpcMethod]
        public string StringMe(string x)
        {
            return x;
        }

        [JsonRpcMethod]
        private double add_1(double l, double r)
        {
            return l + r;
        }

        [JsonRpcMethod]
        private int addInt_1(int l, int r)
        {
            return l + r;
        }

        [JsonRpcMethod]
        public float? NullableFloatToNullableFloat_1(float? a)
        {
            return a;
        }

        [JsonRpcMethod]
        public decimal? Test2_1(decimal x)
        {
            return x;
        }

        [JsonRpcMethod]
        public string StringMe_1(string x)
        {
            return x;
        }

        [JsonRpcMethod]
        private double add_2(double l, double r)
        {
            return l + r;
        }

        [JsonRpcMethod]
        private int addInt_2(int l, int r)
        {
            return l + r;
        }

        [JsonRpcMethod]
        public float? NullableFloatToNullableFloat_2(float? a)
        {
            return a;
        }

        [JsonRpcMethod]
        public decimal? Test2_2(decimal x)
        {
            return x;
        }

        [JsonRpcMethod]
        public string StringMe_2(string x)
        {
            return x;
        }

        [JsonRpcMethod]
        private double add_3(double l, double r)
        {
            return l + r;
        }

        [JsonRpcMethod]
        private int addInt_3(int l, int r)
        {
            return l + r;
        }

        [JsonRpcMethod]
        public float? NullableFloatToNullableFloat_3(float? a)
        {
            return a;
        }

        [JsonRpcMethod]
        public decimal? Test2_3(decimal x)
        {
            return x;
        }

        [JsonRpcMethod]
        public string StringMe_3(string x)
        {
            return x;
        }
    }
}
