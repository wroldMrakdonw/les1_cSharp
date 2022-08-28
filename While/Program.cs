Console.Clear();
int xa = 50, ya = 1,
    xb = 1, yb = 30,
    xc = 100, yc = 30;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");
Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");
Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");

int x = xa, y = ya;

int count = 0;

while (count < 10000) {
    int randNum = new Random().Next(0,3);
    if (randNum == 0) {
        x = (Math.Abs(x - xa)) / 2;
        y = (Math.Abs(y - ya)) / 2; 
    }

    if (randNum == 1) {
        x = (Math.Abs(x - xb)) / 2;
        y = (Math.Abs(y - yb)) / 2; 
    }

    if (randNum == 2) {
        x = (Math.Abs(x - xc)) / 2;
        y = (Math.Abs(y - yc)) / 2; 
    }

    Console.SetCursorPosition(x,y);
    Console.WriteLine("+");
    count++;
}