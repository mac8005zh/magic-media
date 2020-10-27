﻿using System;
using System.Collections;
using System.Collections.Generic;
using StrawberryShake;

namespace MagicMedia.Api.Host.Tests
{
    public class Queries
        : IDocument
    {
        private readonly byte[] _hashName = new byte[]
        {
            109,
            100,
            53,
            72,
            97,
            115,
            104
        };
        private readonly byte[] _hash = new byte[]
        {
            75,
            78,
            116,
            117,
            83,
            70,
            49,
            50,
            101,
            122,
            71,
            53,
            54,
            43,
            97,
            117,
            90,
            49,
            66,
            56,
            49,
            103,
            61,
            61
        };
        private readonly byte[] _content = new byte[]
        {
            113,
            117,
            101,
            114,
            121,
            32,
            109,
            101,
            100,
            105,
            97,
            68,
            101,
            116,
            97,
            105,
            108,
            115,
            40,
            36,
            105,
            100,
            58,
            32,
            85,
            117,
            105,
            100,
            33,
            41,
            32,
            123,
            32,
            109,
            101,
            100,
            105,
            97,
            66,
            121,
            73,
            100,
            40,
            105,
            100,
            58,
            32,
            36,
            105,
            100,
            41,
            32,
            123,
            32,
            95,
            95,
            116,
            121,
            112,
            101,
            110,
            97,
            109,
            101,
            32,
            105,
            100,
            32,
            102,
            105,
            108,
            101,
            110,
            97,
            109,
            101,
            32,
            100,
            97,
            116,
            101,
            84,
            97,
            107,
            101,
            110,
            32,
            99,
            97,
            109,
            101,
            114,
            97,
            73,
            100,
            32,
            100,
            105,
            109,
            101,
            110,
            115,
            105,
            111,
            110,
            32,
            123,
            32,
            95,
            95,
            116,
            121,
            112,
            101,
            110,
            97,
            109,
            101,
            32,
            104,
            101,
            105,
            103,
            104,
            116,
            32,
            119,
            105,
            100,
            116,
            104,
            32,
            125,
            32,
            99,
            97,
            109,
            101,
            114,
            97,
            32,
            123,
            32,
            95,
            95,
            116,
            121,
            112,
            101,
            110,
            97,
            109,
            101,
            32,
            105,
            100,
            32,
            109,
            111,
            100,
            101,
            108,
            32,
            109,
            97,
            107,
            101,
            32,
            125,
            32,
            102,
            97,
            99,
            101,
            115,
            32,
            123,
            32,
            95,
            95,
            116,
            121,
            112,
            101,
            110,
            97,
            109,
            101,
            32,
            105,
            100,
            32,
            98,
            111,
            120,
            32,
            123,
            32,
            95,
            95,
            116,
            121,
            112,
            101,
            110,
            97,
            109,
            101,
            32,
            108,
            101,
            102,
            116,
            32,
            116,
            111,
            112,
            32,
            114,
            105,
            103,
            104,
            116,
            32,
            98,
            111,
            116,
            116,
            111,
            109,
            32,
            125,
            32,
            116,
            104,
            117,
            109,
            98,
            110,
            97,
            105,
            108,
            32,
            123,
            32,
            95,
            95,
            116,
            121,
            112,
            101,
            110,
            97,
            109,
            101,
            32,
            105,
            100,
            32,
            125,
            32,
            112,
            101,
            114,
            115,
            111,
            110,
            32,
            123,
            32,
            95,
            95,
            116,
            121,
            112,
            101,
            110,
            97,
            109,
            101,
            32,
            105,
            100,
            32,
            110,
            97,
            109,
            101,
            32,
            100,
            97,
            116,
            101,
            79,
            102,
            66,
            105,
            114,
            116,
            104,
            32,
            103,
            114,
            111,
            117,
            112,
            32,
            125,
            32,
            112,
            101,
            114,
            115,
            111,
            110,
            73,
            100,
            32,
            125,
            32,
            116,
            104,
            117,
            109,
            98,
            110,
            97,
            105,
            108,
            40,
            115,
            105,
            122,
            101,
            58,
            32,
            77,
            41,
            32,
            123,
            32,
            95,
            95,
            116,
            121,
            112,
            101,
            110,
            97,
            109,
            101,
            32,
            105,
            100,
            32,
            115,
            105,
            122,
            101,
            32,
            100,
            97,
            116,
            97,
            85,
            114,
            108,
            32,
            100,
            105,
            109,
            101,
            110,
            115,
            105,
            111,
            110,
            115,
            32,
            123,
            32,
            95,
            95,
            116,
            121,
            112,
            101,
            110,
            97,
            109,
            101,
            32,
            104,
            101,
            105,
            103,
            104,
            116,
            32,
            119,
            105,
            100,
            116,
            104,
            32,
            125,
            32,
            125,
            32,
            125,
            32,
            125
        };

        public ReadOnlySpan<byte> HashName => _hashName;

        public ReadOnlySpan<byte> Hash => _hash;

        public ReadOnlySpan<byte> Content => _content;

        public static Queries Default { get; } = new Queries();

        public override string ToString() => 
            @"query mediaDetails($id: Uuid!) {
              mediaById(id: $id) {
                id
                filename
                dateTaken
                cameraId
                dimension {
                  height
                  width
                }
                camera {
                  id
                  model
                  make
                }
                faces {
                  id
                  box {
                    left
                    top
                    right
                    bottom
                  }
                  thumbnail {
                    id
                  }
                  person {
                    id
                    name
                    dateOfBirth
                    group
                  }
                  personId
                }
                thumbnail(size: M) {
                  id
                  size
                  dataUrl
                  dimensions {
                    height
                    width
                  }
                }
              }
            }";
    }
}
