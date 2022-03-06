package ui._050322;

import java.io.DataOutputStream;
import java.net.Socket;
import java.util.Scanner;

/**
 *
 * @author New King
 */
public class BT_05032022_De_1 extends javax.swing.JFrame {

    /**
     * Creates new form BT_05032022_De_1
     */
    public BT_05032022_De_1() {
        initComponents();
    }

    /**
     * This method is called from within the constructor to initialize the form.
     * WARNING: Do NOT modify this code. The content of this method is always
     * regenerated by the Form Editor.
     */
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        txtTitle = new javax.swing.JTextArea();
        txtNum1 = new javax.swing.JTextField();
        txtNum2 = new javax.swing.JTextField();
        txtNum3 = new javax.swing.JTextField();
        txtNum4 = new javax.swing.JTextField();
        txtNum5 = new javax.swing.JTextField();
        btnAns = new javax.swing.JButton();
        txtAns1 = new javax.swing.JTextField();
        txtAns2 = new javax.swing.JTextField();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
        setTitle("Đề 1");
        setName("frame1"); // NOI18N
        setType(java.awt.Window.Type.POPUP);

        txtTitle.setEditable(false);
        txtTitle.setBackground(java.awt.SystemColor.control);
        txtTitle.setColumns(20);
        txtTitle.setFont(new java.awt.Font("Segoe UI", 0, 14)); // NOI18N
        txtTitle.setLineWrap(true);
        txtTitle.setRows(2);
        txtTitle.setText("Đề bài số 1: Viết chương trình nhập vào 5 số nguyên bất kỳ, đếm xem có bao nhiêu số nguyên tố. Tính tổng các số nguyên tố không chia hết cho 3 và 7");
        txtTitle.setToolTipText("");
        txtTitle.setWrapStyleWord(true);
        txtTitle.setName("txtTiltle"); // NOI18N

        txtNum1.setFont(new java.awt.Font("Segoe UI", 0, 12)); // NOI18N
        txtNum1.setHorizontalAlignment(javax.swing.JTextField.CENTER);
        txtNum1.setText("0");
        txtNum1.setMinimumSize(new java.awt.Dimension(50, 22));

        txtNum2.setFont(new java.awt.Font("Segoe UI", 0, 12)); // NOI18N
        txtNum2.setHorizontalAlignment(javax.swing.JTextField.CENTER);
        txtNum2.setText("0");
        txtNum2.setMinimumSize(new java.awt.Dimension(50, 22));

        txtNum3.setFont(new java.awt.Font("Segoe UI", 0, 12)); // NOI18N
        txtNum3.setHorizontalAlignment(javax.swing.JTextField.CENTER);
        txtNum3.setText("0");
        txtNum3.setMinimumSize(new java.awt.Dimension(50, 22));

        txtNum4.setFont(new java.awt.Font("Segoe UI", 0, 12)); // NOI18N
        txtNum4.setHorizontalAlignment(javax.swing.JTextField.CENTER);
        txtNum4.setText("0");
        txtNum4.setMinimumSize(new java.awt.Dimension(50, 22));

        txtNum5.setFont(new java.awt.Font("Segoe UI", 0, 12)); // NOI18N
        txtNum5.setHorizontalAlignment(javax.swing.JTextField.CENTER);
        txtNum5.setText("0");
        txtNum5.setMinimumSize(new java.awt.Dimension(50, 22));

        btnAns.setText("Tính");
        btnAns.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnAnsActionPerformed(evt);
            }
        });

        txtAns1.setEditable(false);
        txtAns1.setFont(new java.awt.Font("Segoe UI", 0, 11)); // NOI18N

        txtAns2.setEditable(false);
        txtAns2.setFont(new java.awt.Font("Segoe UI", 0, 11)); // NOI18N

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(txtTitle)
                    .addComponent(txtAns1)
                    .addComponent(txtAns2)
                    .addGroup(layout.createSequentialGroup()
                        .addComponent(txtNum1, javax.swing.GroupLayout.PREFERRED_SIZE, 50, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addGap(18, 18, 18)
                        .addComponent(txtNum2, javax.swing.GroupLayout.PREFERRED_SIZE, 50, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addGap(18, 18, 18)
                        .addComponent(txtNum3, javax.swing.GroupLayout.PREFERRED_SIZE, 50, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addGap(18, 18, 18)
                        .addComponent(txtNum4, javax.swing.GroupLayout.PREFERRED_SIZE, 50, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addGap(18, 18, 18)
                        .addComponent(txtNum5, javax.swing.GroupLayout.PREFERRED_SIZE, 50, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addGap(18, 18, 18)
                        .addComponent(btnAns)
                        .addGap(0, 0, Short.MAX_VALUE)))
                .addContainerGap())
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addComponent(txtTitle, javax.swing.GroupLayout.PREFERRED_SIZE, 67, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(8, 8, 8)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.CENTER)
                    .addComponent(txtNum5, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(btnAns)
                    .addComponent(txtNum1, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(txtNum2, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(txtNum3, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(txtNum4, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(txtAns1, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(txtAns2, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private static final int SERVER_PORT = 1234;
    private static final String SERVER_HOST = "127.0.0.1";

    private void btnAnsActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnAnsActionPerformed
        try {
            // Kết nối đến server
            Socket clientSocket = new Socket(SERVER_HOST, SERVER_PORT);

            // Gửi dữ liệu từ client sang server
            DataOutputStream sendToServer = new DataOutputStream(clientSocket.getOutputStream());
            String input = txtNum1.getText() + " " + txtNum2.getText() + " " + txtNum3.getText() + " " + txtNum4.getText() + " " + txtNum5.getText();
            sendToServer.writeBytes(input + "\n");

            // Nhận dữ liệu phản hồi của server
            Scanner sc = new Scanner(clientSocket.getInputStream());
            txtAns1.setText("Có " + sc.nextLine() + " số nguyên tố");
            txtAns2.setText("Tổng = " + sc.nextLine());

            clientSocket.close(); // Đóng kết nối
        } catch (Exception ex) {
            // TODO: handle exception
        }
    }//GEN-LAST:event_btnAnsActionPerformed

    /**
     * @param args the command line arguments
     */
    public static void main(String args[]) {
        /* Set the Nimbus look and feel */
        //<editor-fold defaultstate="collapsed" desc=" Look and feel setting code (optional) ">
        /* If Nimbus (introduced in Java SE 6) is not available, stay with the default look and feel.
         * For details see http://download.oracle.com/javase/tutorial/uiswing/lookandfeel/plaf.html 
         */
        try {
            for (javax.swing.UIManager.LookAndFeelInfo info : javax.swing.UIManager.getInstalledLookAndFeels()) {
                if ("Metal".equals(info.getName())) {
                    javax.swing.UIManager.setLookAndFeel(info.getClassName());
                    break;
                }
            }
        } catch (ClassNotFoundException ex) {
            java.util.logging.Logger.getLogger(BT_05032022_De_1.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(BT_05032022_De_1.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(BT_05032022_De_1.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(BT_05032022_De_1.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>

        /* Create and display the form */
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new BT_05032022_De_1().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton btnAns;
    private javax.swing.JTextField txtAns1;
    private javax.swing.JTextField txtAns2;
    private javax.swing.JTextField txtNum1;
    private javax.swing.JTextField txtNum2;
    private javax.swing.JTextField txtNum3;
    private javax.swing.JTextField txtNum4;
    private javax.swing.JTextField txtNum5;
    private javax.swing.JTextArea txtTitle;
    // End of variables declaration//GEN-END:variables
}
