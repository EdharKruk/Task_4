using LegacyApp;

public interface IClientRepository
{
    Client GetById(int clientId);
}

public interface IUserCreditService
{
    void AssignCreditLimit(Client client, User user);
}

public interface IUserRepository
{
    void AddUser(User user);
}