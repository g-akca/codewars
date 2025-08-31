#include <string>
using namespace std;

int digital_root(int n)
{
  while (n >= 10) {
    string m = to_string(n);
    n = 0;
    for (int i = 0; i < m.length(); i++) {
      n += m[i] - '0';
    }
  }
  return n;
}