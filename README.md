### PhotonSpin

---

[![PhotonSpin](https://repository-images.githubusercontent.com/1041831197/1b727646-247b-48fd-9532-a10ee732e60a "PhotonSpin")](https://github.com/wstaffordp/photonspin#photonspin64)

---

PhotonSpin is a PRNG that outperforms SHISHUA as the fastest large-period, statistically-strong PRNG in the world. Anyone is free to use it without warranty.

---

#### PhotonSpin64

PhotonSpin64 provides enhanced parallelism, period and speed with similar statistical test results as an ideal alternative to SHISHUA.

It has a period of at least 2¹⁰²⁴.

Each state integer must be assigned a seed. Seeding `a` with non-overlapping integers and seeding the remaining state with overlapping integers behaves as a jump function with up to 2⁶⁴ parallel instances that each have a non-overlapping period of at least 2⁶⁴. The first result of 20 integers from each parallel instance should be skipped.

##### C

`photonspin64` generates and assigns 20 pseudorandom `uint64_t` integers to `elements`, provided the implementation supports a 64-bit, unsigned integral type for `uint64_t`.

##### C#

`Next` from `PhotonSpin64` generates and assigns 20 pseudorandom `ulong` integers to `elements`.

---

#### PhotonSpin32

PhotonSpin32 provides enhanced parallelism, period and speed with similar statistical test results as an ideal alternative to 32-bit variants of SHISHUA.

It has a period of at least 2⁵¹².

Each state integer must be assigned a seed. Seeding `a` with non-overlapping integers and seeding the remaining state with overlapping integers behaves as a jump function with up to 2³² parallel instances that each have a non-overlapping period of at least 2³². The first result of 20 integers from each parallel instance should be skipped.

##### C

`photonspin32` generates and assigns 20 pseudorandom `uint32_t` integers to `elements`, provided the implementation supports a 32-bit, unsigned integral type for `uint32_t`.

##### C#

`Next` from `PhotonSpin32` generates and assigns 20 pseudorandom `uint` integers to `elements`.
