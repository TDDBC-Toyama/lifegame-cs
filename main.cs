using System;

class MainClass {
  public static void Main() {
    String[][] b = new String[5][];

    for (int i = 0; i < 5; i++) {
      b[i] = new String[5];
      for (int j = 0; j < 5; j++) {
        b[i][j] = "□";
      }
    }

    for (int i = 0; i < 5; i++) {
      String line = "";
      for (int j = 0; j < 5; j++) {
        line = line + b[i][j];
      }
      Console.WriteLine(line);
    }
  }
}
