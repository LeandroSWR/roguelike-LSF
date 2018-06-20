﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueLike {
    class Player {
        private const int maxWeight = 20;
        private float baseWeight;
        public int x, y;
        public string LastMove { get; set; }

        public float Hp { get; set; } = 100;

        public float Weight {
            get {
                return baseWeight;
            }
        }

        public Player(float baseWeight) {
            this.baseWeight = baseWeight;
        }
    }
}