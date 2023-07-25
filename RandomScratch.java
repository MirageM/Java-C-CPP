import java.util.Random;

class RandomScratch{
    public static void main(String[] args){
        Random rand = new Random();
        System.out.println(rand.nextInt(5));
        //prints a random Int between 0 - 4 (including 0 & 4);
    }
}