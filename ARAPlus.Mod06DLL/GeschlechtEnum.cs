using System;

public enum Geschlecht 
{
    Frau=1,
    Mann=2,
    Divers=3
}

[Flags]
public enum Wetter : byte
{
    Sonnig=1,
    Warm=2,
    Kalt=4,
    Regnerisch=8,
    Schnee=16
}