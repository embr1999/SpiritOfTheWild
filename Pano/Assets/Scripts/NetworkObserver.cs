using UnityEngine;
using System;
using System.Net.Sockets;
using System.Text;

public class NetworkObserver : MonoBehaviour
{
    private TcpClient tcpClient;
    private NetworkStream networkStream;
    private byte[] receiveBuffer = new byte[1024];

    [SerializeField] private bool local = false;

    // Server IP and Port
    [SerializeField] 
    [Tooltip("If local is checked then all input will be ignored")]
    private string serverIP = "0.0.0.0";
    private string localhostIP = "127.0.0.1";
    [SerializeField]  private int port = 0;

    void Start()
    {
        if(local){
            serverIP = localhostIP;
        }

        // Connect to the server
        ConnectToServer();
    }
    void Update()
    {
        // Check for incoming data
        ReadData();
    }

    private void ConnectToServer()
    {
        try
        {
            tcpClient = new TcpClient(serverIP, port);
            networkStream = tcpClient.GetStream();
            Debug.Log("Connected to server.");
        }
        catch (SocketException ex)
        {
            Debug.LogError($"SocketException: {ex.ErrorCode} - {ex.Message}");
        }
        catch (Exception e)
        {
            Debug.LogError($"Error connecting to server: {e.Message}");
        }
    }

    private void ReadData()
    {
        if (networkStream != null && networkStream.DataAvailable)
        {
            try
            {
                int bytesRead = networkStream.Read(receiveBuffer, 0, receiveBuffer.Length);
                string receivedData = Encoding.UTF8.GetString(receiveBuffer, 0, bytesRead);
                Debug.Log($"Received data: {receivedData}");
            }
            catch (Exception e)
            {
                Debug.LogError($"Error reading data: {e.Message}");
            }
        }
    }

    private void OnDestroy()
    {
        // Clean up resources when the script is destroyed
        if (tcpClient != null)
            tcpClient.Close();
    }
}