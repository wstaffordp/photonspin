#ifndef PHOTONSPIN_H
#define PHOTONSPIN_H

#include <stdint.h>

struct photonspin64_s {
  uint64_t elements[20];
  uint64_t a;
  uint64_t b;
  uint64_t c;
};

struct photonspin32_s {
  uint32_t elements[20];
  uint32_t a;
  uint32_t b;
  uint32_t c;
};

void photonspin64(struct photonspin64_s *s);

void photonspin32(struct photonspin32_s *s);

#endif
