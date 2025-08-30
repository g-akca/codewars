#include <string>
#include <vector>
using namespace std;

std::string likes(const std::vector<std::string> &names)
{
  int n = names.size();
  if (n == 0) return "no one likes this";
  if (n == 1) return names[0] + " likes this";
  if (n == 2) return names[0] + " and " + names[1] + " like this";
  if (n == 3) return names[0] + ", " + names[1] + " and " + names[2] + " like this";
  return names[0] + ", " + names[1] + " and " + to_string(n - 2) + " others like this";
}