// See https://aka.ms/new-console-template for more information
using Proxy;
{ 
ISafeDb safeDatabase=new SafeDbProxy("Testing","password");
safeDatabase.DisplayDbname(); 
 }