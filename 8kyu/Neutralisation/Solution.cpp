#include <string>
using namespace std;

std::string neutralise(const std::string& s1, const std::string& s2)
{
  string result;
  for (int i = 0; i < s1.length(); i++) {
    if (s1[i] == '+' && s2[i] == '+') result += '+';
    else if (s1[i] == '-' && s2[i] == '-') result += '-';
    else result += '0';
  }
  
  return result;
}