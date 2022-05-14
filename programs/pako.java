import java.util.*;
import java.lang.Math;

/*
for arduino
*/

public class JavaApplication {
    private static Scanner input = new Scanner(System.in);

    public static void main(String[] args) {
        boolean boolin0, boolin1, boolout0, boolout1, boolout2, boolout3, boolout4, boolout14, boolout15;
        
        boolin0 = input.nextBoolean();
        boolin1 = input.nextBoolean();
        boolout0 = input.nextBoolean();
        boolout1 = input.nextBoolean();
        boolout2 = input.nextBoolean();
        boolout3 = input.nextBoolean();
        boolout4 = input.nextBoolean();
        boolout14 = input.nextBoolean();
        boolout15 = input.nextBoolean();
        if (boolin1) {
            System.out.println("Stopped");
            do {
                reset();
            } while (boolin1);
        } else {
            boolin0 = true;
            System.out.println("Running");
            while (true) {
                boolin1 = input.nextBoolean();
                while (!boolin1) {
                    System.out.println("Stopped");
                    do {
                        reset();
                    } while (boolin1);
                }
            }
        }
    }
    
    public static boolean reset() {
        reset();
        return ;
    }
}
