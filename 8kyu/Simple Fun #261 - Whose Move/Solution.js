function whoseMove(lastPlayer, win) {
  //coding and coding..
  if ((lastPlayer === "black" && win) || (lastPlayer === "white" && !win)) return "black";
  else return "white";
}