Imports System.ServiceModel

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IListado" in both code and config file together.
<ServiceContract()>
Public Interface IListado

    <OperationContract()>
    Sub DoWork()

End Interface
