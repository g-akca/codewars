#include <vector>

double calcAverage(const std::vector<int>& values){
  double avg = 0, n = values.size();
  for (int i = 0; i < n; i++) {
    avg += values[i];
  }
  return avg / n;
}
