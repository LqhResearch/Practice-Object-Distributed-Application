package server;

import java.io.*;
import java.net.ServerSocket;
import java.net.Socket;

public class Server {

    private static int SERVER_PORT = 1234;

    private static double Calculate(int num1, char operator, int num2) {
        switch (operator) {
            case '+':
                return num1 + num2;
            case '-':
                return num1 - num2;
            case '*':
                return num1 * num2;
            case '/':
                return 1.0 * num1 / num2;
            default:
                return num1 + num2;
        }
    }

    public static void Process() {
        try {
            // Kết nối đến server
            ServerSocket serverSocket = new ServerSocket(SERVER_PORT);
            System.out.println("Server đang chờ ...");

            while (true) {
                // Nhập dữ liệu từ server
                Socket port = serverSocket.accept();
                BufferedReader reader = new BufferedReader(new InputStreamReader(port.getInputStream()));
                int num1 = Integer.parseInt(reader.readLine());
                char operator = reader.readLine().charAt(0);
                int num2 = Integer.parseInt(reader.readLine());

                // Xử lý tính toán và trả kết quả phản hồi về trong client
                DataOutputStream sendToClient = new DataOutputStream(port.getOutputStream());
                sendToClient.writeBytes(Calculate(num1, operator, num2) + "\n");
            }
        } catch (Exception ex) {
            // TODO: handle exception
        }
    }

    public static void main(String[] args) {
        Process();
    }
}
