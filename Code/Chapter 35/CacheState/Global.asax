<%@ Application Language="VB" %>
<%@ Import Namespace = "System.Data" %>
<%@ Import Namespace="AutoLotConnectedLayer" %>

<script runat="server">
  ' Define a shared Cache member variable.
  Shared theCache As Cache
  Shared cnStr As String
  Sub Application_Start(ByVal sender As Object, ByVal e As EventArgs)
    ' First assign the shared'theCache' variable.
    theCache = Context.Cache
    cnStr = "Data Source=(local)\SQLEXPRESS;Initial Catalog=AutoLot;Integrated Security=True"
    ' Add a DataSet to the cache via a helper function.
    AddDataTableToCache()
  End Sub

  Shared Sub AddDataTableToCache()
    ' When the application starts up,
    ' read the current records in the
    ' Inventory table of the AutoLot DB.
    Dim dal As New InventoryDAL()
    dal.OpenConnection(cnStr)
    Dim theCars As DataTable = dal.GetAllInventory()
    dal.CloseConnection()
    
    ' Now store DataTable in the cache.
    theCache.Insert("AppDataTable", _
      theCars, Nothing, _
      DateTime.Now.AddSeconds(15), _
      Cache.NoSlidingExpiration, _
      CacheItemPriority.Default, _
      New CacheItemRemovedCallback(AddressOf UpdateCarInventory))
  End Sub
  
  ' The target for the CacheItemRemovedCallback delegate.
  Shared Sub UpdateCarInventory(ByVal key As String, ByVal item As Object, _
    ByVal reason As CacheItemRemovedReason)

    Dim dal As New InventoryDAL()
    dal.OpenConnection(cnStr)
    Dim theCars As DataTable = dal.GetAllInventory()
    dal.CloseConnection()
      
    ' Now store DataTable in the cache.
    theCache.Insert("AppDataTable", _
      theCars, Nothing, _
      DateTime.Now.AddSeconds(15), _
      Cache.NoSlidingExpiration, _
      CacheItemPriority.Default, _
      New CacheItemRemovedCallback(AddressOf UpdateCarInventory))
  End Sub

  Sub Application_End(ByVal sender As Object, ByVal e As EventArgs)
    ' Code that runs on application shutdown
  End Sub
      
  Sub Application_Error(ByVal sender As Object, ByVal e As EventArgs)
    ' Code that runs when an unhandled error occurs
  End Sub

  Sub Session_Start(ByVal sender As Object, ByVal e As EventArgs)
    ' Code that runs when a new session is started
  End Sub

  Sub Session_End(ByVal sender As Object, ByVal e As EventArgs)
    ' Code that runs when a session ends. 
    ' Note: The Session_End event is raised only when the sessionstate mode
    ' is set to InProc in the Web.config file. If session mode is set to StateServer 
    ' or SQLServer, the event is not raised.
  End Sub
     
</script>