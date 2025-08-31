#include <vector>
#include <string>
using namespace std;

std::string findNeedle(const std::vector<std::string>& haystack)
{
  for (int i = 0; i < haystack.size(); i++) {
    if (haystack[i] == "needle") {
      return "found the needle at position " + std::to_string(i);
    }
  }
}