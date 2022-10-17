using System;

EmptySet empty = new EmptySet();
EmptySet empty2 = new EmptySet();
EmptySet empty3 = new EmptySet();

PairSet pair = new PairSet();
pair.A = empty;
pair.B = empty;

Console.WriteLine(pair.IsIn(empty3));