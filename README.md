# TP_-ReservaTransporte-_-Pierro-Robledo-  
nuestro sistema gestionara reservas de vehículos de transporte 


las entidades principales que tendrá son (clientes, chofer, tipoVehiculo, vehiculo, reserva y pago)


los objetivos serán que pueda registrar clientes, reservas, choferes y vehículos además de los pagos

El programa deberá reportar pagos el método en el que se pagara y el monto final 

de los vehículos reportara el modelo, la patente y marca del vehículo y además el coste por días 

la entidad cliente va a reportar  los datos personales de la persona, el numero de teléfono y su licencia 

y de las reservas reportara id  entidad cliente y  entidad vehículo, si se da el caso que se selecciona la opción de reservar con chofer también se sumaran esos datos además de la cantidad de días de reserva, el seguro y una seña  

también modificara pagos, clientes y choferes 




[Diagrama](https://lucid.app/lucidchart/088fcd7d-5bde-48a9-9ca5-a4ec8cb6bf7f/edit?viewport_loc=-10115%2C-3061%2C2558%2C1298%2C0_0&invitationId=inv_0585586d-f898-4da6-88ff-b67ec5e594c2)




el usuario ingresa datos desde la capa de presentación desarrollada en Windows forms, esta capa envia informacion a la capa de negocio para validar que exista clientes y que el vehiculo este disponible.

la capa de negocio se comunica con la capa de datos, utiliza EntityFramework y el repositorio para agregar la reserva a la base de datos y mediante el DBcontext y savechanges se guarda el registro en la base de datos 
