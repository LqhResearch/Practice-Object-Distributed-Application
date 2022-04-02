package console;

import java.io.*;
import java.net.Socket;
import java.util.Scanner;

public class Client {

    private static final int SERVER_PORT = 1234;
    private static final String SERVER_HOST = "127.0.0.1";

    /**
     * Thực hành 26/02/2022: Nhập vào hai số nguyên và toán tử. Tính cộng, trừ,
     * nhân hoặc chia
     */
    public static void Calculate() {
        Scanner sc = new Scanner(System.in);
        System.out.print("- Số thứ nhất: ");
        int num1 = sc.nextInt();
        System.out.print("- Phép toán: ");
        char operator = new Scanner(System.in).nextLine().charAt(0);
        System.out.print("- Số thứ hai: ");
        int num2 = sc.nextInt();

        try {
            // Kết nối đến server
            Socket clientSocket = new Socket(SERVER_HOST, SERVER_PORT);

            // Gửi dữ liệu từ client sang server
            DataOutputStream sendToServer = new DataOutputStream(clientSocket.getOutputStream());
            sendToServer.writeBytes(num1 + "\n");
            sendToServer.writeBytes(operator + "\n");
            sendToServer.writeBytes(num2 + "\n");

            // Nhận dữ liệu phản hồi của server
            Scanner scanner = new Scanner(clientSocket.getInputStream());
            System.out.println("Kết quả: " + scanner.nextLine());

            clientSocket.close(); // Đóng kết nối
        } catch (IOException ex) {
            // TODO: handle exception
        }
    }

    public static void main(String[] args) {
        Calculate();
    }
}
