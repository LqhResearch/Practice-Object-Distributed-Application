package server;

import java.io.*;
import java.net.ServerSocket;
import java.net.Socket;
import java.util.Scanner;

public class Server {

    private static final int SERVER_PORT = 1234;

    /**
     * Thực hành 26/02/2022: Nhập vào hai số nguyên và toán tử. Tính cộng, trừ,
     * nhân hoặc chia
     */
    private static void Calculate() {
        try {
            // Kết nối đến server
            ServerSocket serverSocket = new ServerSocket(SERVER_PORT);
            System.out.println("Server đang chờ ...");

            while (true) {
                // Nhập dữ liệu từ server
                Socket port = serverSocket.accept();
                Scanner sc = new Scanner(port.getInputStream());
                int num1 = Integer.parseInt(sc.nextLine());
                char operator = sc.nextLine().charAt(0);
                int num2 = Integer.parseInt(sc.nextLine());

                // Xử lý tính toán
                double res = 0.0;
                switch (operator) {
                    case '+':
                        res = num1 + num2;
                        break;
                    case '-':
                        res = num1 - num2;
                        break;
                    case '*':
                        res = num1 * num2;
                        break;
                    case '/':
                        res = 1.0 * num1 / num2;
                        break;
                    default:
                        res = num1 + num2;
                        break;
                }

                // Trả kết quả phản hồi về trong client
                DataOutputStream sendToClient = new DataOutputStream(port.getOutputStream());
                sendToClient.writeBytes(res + "\n");
            }
        } catch (IOException | NumberFormatException ex) {

        }
    }

    /**
     * Thực hành 26/02/2022: Viết chương trình nhập vào 5 số nguyên bất kỳ, đếm
     * xem có bao nhiêu số nguyên tố. Tính tổng các số nguyên tố không chia hết
     * cho 3 và 7
     */
    private static void BT_05032022_De_1() {
        try {
            // Kết nối đến server
            ServerSocket serverSocket = new ServerSocket(SERVER_PORT);
            System.out.println("Server đang chờ ...");

            while (true) {
                // Nhập dữ liệu từ server
                Socket port = serverSocket.accept();
                Scanner sc = new Scanner(port.getInputStream());
                String arr[] = sc.nextLine().split(" ");

                // Xử lý tính toán
                int sum = 0, count = 0;
                for (int i = 0; i < arr.length; i++) {
                    int num = Integer.parseInt(arr[i]);
                    if (isPrime(num)) {
                        count++;
                        if (num % 3 != 0 && num % 7 != 0) {
                            sum += num;
                        }
                    }
                }

                // Trả kết quả phản hồi về trong client
                DataOutputStream sendToClient = new DataOutputStream(port.getOutputStream());
                sendToClient.writeBytes(count + "\n");
                sendToClient.writeBytes(sum + "\n");
            }
        } catch (IOException | NumberFormatException ex) {

        }
    }

    private static boolean isPrime(int n) {
        if (n < 2) {
            return false;
        }
        for (int i = 2; i <= Math.sqrt(n); i++) {
            if (n % i == 0) {
                return false;
            }
        }
        return true;
    }

    /**
     * Thực hành 26/02/2022: Viết chương trình nhập vào 5 số nguyên bất kỳ, đếm
     * xem có bao nhiêu số chia hết cho 3 nhưng không chia hết cho 6. Tính tổng
     * các số chẵn và số lẻ
     */
    private static void BT_05032022_De_2() {
        try {
            // Kết nối đến server
            ServerSocket serverSocket = new ServerSocket(SERVER_PORT);
            System.out.println("Server đang chờ ...");

            while (true) {
                // Nhập dữ liệu từ server
                Socket port = serverSocket.accept();
                Scanner sc = new Scanner(port.getInputStream());
                String arr[] = sc.nextLine().split(" ");

                // Xử lý tính toán
                int sumOdd = 0, sumEven = 0, count = 0;
                for (int i = 0; i < arr.length; i++) {
                    int num = Integer.parseInt(arr[i]);
                    if (num % 3 == 0 && num % 6 != 0) {
                        count++;
                    }
                    if (num % 2 == 0) {
                        sumEven += num;
                    } else {
                        sumOdd += num;
                    }
                }

                // Trả kết quả phản hồi về trong client
                DataOutputStream sendToClient = new DataOutputStream(port.getOutputStream());
                sendToClient.writeBytes(count + "\n");
                sendToClient.writeBytes(sumOdd + "\n");
                sendToClient.writeBytes(sumEven + "\n");
            }
        } catch (IOException | NumberFormatException ex) {

        }
    }

    /**
     * Thực hành 26/02/2022: Viết chương trình nhập vào 5 số nguyên bất kỳ, đếm
     * xem có bao nhiêu số lẻ, bao nhiêu số chẵn, sắp tăng dần các số chẵn.
     */
    private static void BT_05032022_De_3() {
        try {
            // Kết nối đến server
            ServerSocket serverSocket = new ServerSocket(SERVER_PORT);
            System.out.println("Server đang chờ ...");

            while (true) {
                // Nhập dữ liệu từ server
                Socket port = serverSocket.accept();
                Scanner sc = new Scanner(port.getInputStream());
                String arr[] = sc.nextLine().split(" ");

                // Xử lý tính toán
                int countOdd = 0, countEven = 0;
                for (int i = 0; i < arr.length; i++) {
                    int num = Integer.parseInt(arr[i]);
                    if (num % 2 == 0) {
                        countEven++;
                    } else {
                        countOdd++;
                    }
                }

                for (int i = 0; i < arr.length - 1; i++) {
                    for (int j = i + 1; j < arr.length; j++) {
                        if (Integer.parseInt(arr[i]) % 2 == 0 && Integer.parseInt(arr[j]) % 2 == 0 && Integer.parseInt(arr[i]) > Integer.parseInt(arr[j])) {
                            String tmp = arr[i];
                            arr[i] = arr[j];
                            arr[j] = tmp;
                        }
                    }
                }

                // Trả kết quả phản hồi về trong client
                DataOutputStream sendToClient = new DataOutputStream(port.getOutputStream());
                sendToClient.writeBytes(countOdd + "\n");
                sendToClient.writeBytes(countEven + "\n");
                sendToClient.writeBytes(String.join(" ", arr) + "\n");
            }
        } catch (IOException | NumberFormatException ex) {

        }
    }

    public static void main(String[] args) {
        // Calculate();
        // BT_05032022_De_1();
        // BT_05032022_De_2();
        BT_05032022_De_3();
    }
}
