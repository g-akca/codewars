#include <string>
bool solution(std::string const &str, std::string const &ending) {
  int n = str.length() - 1, m = ending.length() - 1;
  for (int i = 0; i <= m; i++) {
    if (str[n - i] != ending[m - i]) return false;
  }
  return true;
}