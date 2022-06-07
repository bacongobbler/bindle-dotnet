namespace Deislabs.Bindle;

public enum SslMode
{
    // I don't care about security, and I don't want to pay the overhead of encryption.
    Disable,
    // I don't care about security, but I will pay the overhead of encryption if the server insists on it.
    Allow,
    // I don't care about encryption, but I wish to pay the overhead of encryption if the server supports it.
    Prefer,
    // I want my data to be encrypted, and I accept the overhead. I trust that the network will make sure I always connect to the server I want.
    Require,
    // I want my data encrypted, and I accept the overhead. I want to be sure that I connect to a server that I trust.
    VerifyCA,
    // I want my data encrypted, and I accept the overhead. I want to be sure that I connect to a server I trust, and that it's the one I specify.
    VerifyFull,
}
