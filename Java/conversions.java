public class conversions {
    public static void main(String[] args) {
        int i;
        short s=257;
        i = s;
        System.out.println(i);
        float f=0.01f;
        double d;
        d = f;
        System.out.println(d); 
        byte b;
        b = (byte)s;
        System.out.println(b);
        i = (int)d;
        System.out.println(i);
    }
}
