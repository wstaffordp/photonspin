using System;

public class PhotonSpin64 {
  public ulong[] elements = new ulong[20];
  public ulong a;
  public ulong b;
  public ulong c;

  public void Next() {
    ulong[] mix = {
      elements[a & 15],
      elements[(a + 3) & 15],
      elements[(a + 6) & 15],
      elements[(a + 9) & 15]
    };
    byte i = 0;
    byte j;
    byte k = 0;

    a += 1111111111111;

    while (i < 4) {
      b += a;
      c ^= a;
      mix[i] += (b << 19) | (b >> 45);
      j = 0;

      while (j < 5) {
        elements[k] += (mix[i] << 51) | (mix[i] >> 13);
        elements[k] ^= c;
        mix[i] += elements[k];
        j++;
        k++;
      }

      if (
        elements[k - 1] == elements[k - 2] &&
        elements[k - 3] == elements[k - 4]
      ) {
        elements[k - 1] += mix[i] ^ 4692409560;
        elements[k - 2] += mix[i] ^ 301351086269144;
        elements[k - 3] += (mix[i] ^ 297442264) | (mix[i] & 1);
        elements[k - 4] += mix[i] ^ 4814950713639640;
        elements[k - 5] += mix[i];
      }

      i++;
    }

    b += (mix[0] << 47) | (mix[0] >> 17);
    b ^= mix[1];
    c += (mix[2] << 25) | (mix[2] >> 39);
    c ^= mix[3];
  }
}

public class PhotonSpin32 {
  public uint[] elements = new uint[20];
  public uint a;
  public uint b;
  public uint c;

  public void Next() {
    uint[] mix = {
      elements[a & 15],
      elements[(a + 3) & 15],
      elements[(a + 6) & 15],
      elements[(a + 9) & 15]
    };
    byte i = 0;
    byte j;
    byte k = 0;

    a += 111111;

    while (i < 4) {
      b += a;
      c ^= a;
      mix[i] += (b << 9) | (b >> 23);
      j = 0;

      while (j < 5) {
        elements[k] += (mix[i] << 25) | (mix[i] >> 7);
        elements[k] ^= c;
        mix[i] += elements[k];
        j++;
        k++;
      }

      if (
        elements[k - 1] == elements[k - 2] &&
        elements[k - 3] == elements[k - 4]
      ) {
        elements[k - 1] += mix[i] ^ 81016;
        elements[k - 2] += mix[i] ^ 297442264;
        elements[k - 3] += (mix[i] ^ 5480) | (mix[i] & 1);
        elements[k - 4] += mix[i] ^ 19006808;
        elements[k - 5] += mix[i];
      }

      i++;
    }

    b += (mix[0] << 23) | (mix[0] >> 9);
    b ^= mix[1];
    c += (mix[2] << 13) | (mix[2] >> 19);
    c ^= mix[3];
  }
}
