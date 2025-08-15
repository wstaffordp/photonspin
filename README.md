### PhotonSpin

---

[![PhotonSpin](https://repository-images.githubusercontent.com/1038338428/bbbd9cdc-eec6-4c8d-8ee1-fe94c129a312 "PhotonSpin")](https://github.com/wstaffordp/photonspin/tree/master/src)

---

PhotonSpin is a PRNG that outperforms SHISHUA as the fastest large-period, statistically-strong PRNG in the world. Anyone is free to use it without warranty.

---

#### PhotonSpin64

`photonspin64` is a PRNG function that generates 20 64-bit, pseudorandom, unsigned integers from 64-bit state integers.

It accepts the following argument.

1. `s` is the `struct photonspin64_s` pointer that contains the state. Each state integer must be seeded with any `uint64_t` value.

The return value data type is `void`. The output is assigned to `elements`.

It has a minimum period of 2¹⁰²⁴ without broken cycles. Furthermore, a full cycle generates at least 1 of each number from a range of 2⁶⁴ numbers and zeroland escapes quickly with conditionals that prevent excessive subsequent duplicate pairs in each segment of 20 generated numbers.

Up to 2⁶⁴ parallel states each have a non-overlapping cycle of at least 2⁶⁴ numbers by seeding `a` with non-overlapping values and seeding `b`, `c` and `elements` with any combination of overlapping values. The first segment of 20 generated numbers from each parallel cycle should be skipped to avoid correlations.

In conclusion, PhotonSpin64 provides enhanced parallelism, period and speed with similar statistical test results as an ideal alternative to SHISHUA and other PRNGs that output large amounts of state.

---

#### PhotonSpin32

`photonspin32` is a PRNG function that generates 20 32-bit, pseudorandom, unsigned integers from 32-bit state integers.

It accepts the following argument.

1. `s` is the `struct photonspin32_s` pointer that contains the state. Each state integer must be seeded with any `uint32_t` value.

The return value data type is `void`. The output is assigned to `elements`.

It has a minimum period of 2⁵¹² without broken cycles. Furthermore, a full cycle generates at least 1 of each number from a range of 2³² numbers and zeroland escapes quickly with conditionals that prevent excessive subsequent duplicate pairs in each segment of 20 generated numbers.

Up to 2³² parallel states each have a non-overlapping cycle of at least 2³² numbers by seeding `a` with non-overlapping values and seeding `b`, `c` and `elements` with any combination of overlapping values. The first segment of 20 generated numbers from each parallel cycle should be skipped to avoid correlations.

In conclusion, PhotonSpin32 provides enhanced parallelism, period and speed with similar statistical test results as an ideal alternative to 32-bit variants of SHISHUA and other PRNGs that output large amounts of state.

---

Additional PhotonSpin variants are coming soon.
