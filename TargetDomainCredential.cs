//Rename an object and specify the domain controller and credentials directly
public static void Rename(string server,
    string userName, string password, string objectDn, string newName)
{
    DirectoryEntry child = new DirectoryEntry("LDAP://" + server + "/" + 
        objectDn, userName, password);
    child.Rename("CN=" + newName);
}
