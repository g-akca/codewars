#include <string>
#include <unordered_map>
using namespace std;

std::string DNAStrand(const std::string& dna)
{
  unordered_map<char, char> comp;
  comp['A'] = 'T', comp['T'] = 'A', comp['C'] = 'G', comp['G'] = 'C';
  
  string result;
  for (int i = 0; i < dna.length(); i++) {
    result += comp[dna[i]];
  }
  return result;
}