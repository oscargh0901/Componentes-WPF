   M S B A M L   `   `   `  ????\  XDI02_Tarea_Garcia_Hernandez_Oscar, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullU/clr-namespace:DI02_Tarea_Garcia_Hernandez_Oscar!DI02_Tarea_Garcia_Hernandez_Oscar  5   	   m;clr-namespace:DI02_Tarea_Garcia_Hernandez_Oscar.Componentes-DI02_Tarea_Garcia_Hernandez_Oscar.Componentes  5   	   :    4DI02_Tarea_Garcia_Hernandez_Oscar.ModalPerfilCliente   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Alocal/clr-namespace:DI02_Tarea_Garcia_Hernandez_Oscar     5   	   Scomponentes;clr-namespace:DI02_Tarea_Garcia_Hernandez_Oscar.Componentes     5   	     ? Title$
  Cita??5	   	   $	??400??6   $	??450??6#   .??5
      ? -   5         ? RowDefinitions 5   
   ?? 5      $
??Auto ?6   6,   ?? 5      $
??Auto ?6   6,   ?? 5      $
??Auto ?6   6,   ?? 5      $
??Auto ?6   6,   ?? 5      $
??Auto ?6   6,   ?? 5      $
??Auto ?6   6,   ?? 5      $
??Auto ?6   6,   ?? 5      $
??Auto ?6   6,   ?? 5      $
??Auto ?6   6,    ? ColumnDefinitions 5   
   ?? 5      $
??Auto ?6   6.   ?? 5      $
??Auto ?6   6.   .+?5   
   ?? $??Nombre??6   $??0??6!   $??0??61   ?? 5   
   -   5         ??Name$ TextBoxName??5      $??0,5,0,5q?6'   $??1??68   $??0??6H    ? ToolTip$3 -Indicanos tu nombre para ponernos en contacto??6U    ?? TextWrapping$
 Wrap=?6?    ?? 	IsEnabled$
 True??6?   ??6?   ??  ?? Path$ Nombre? ?? NotifyOnValidationError$
 True??	 ?? ValidatesOnDataErrors$
	 True??6  ?? 5   
   $??	Apellidos??6   $??0??6$   $??1??64   ?? 5    
   -   5        $ TextBoxSurnames??5       $??0,5,0,5q?6+   $??1??6<   $??1??6L   $7 1Indicanos tus apellidos para ponernos en contacto??6Y   $
 Wrap=?6?   $
 True??6  ??6?   ?? $ Surnames?$
 True??$
	 True??6  ?? 5"   
   $??Telefono??6   $??0??6#   $??2??63   ?? 5#   
   -   5        $ TextBoxPhoneNumber??5#      $??0,5,0,5q?6.   $??1??6?   $??2??6O   $? 9Indicanos tu numero de telefono para ponernos en contacto??6\   $
 Wrap=?6?   $
 True??6  ??6?   ?? $ PhoneNumber?$
 True??$
	 True??6-  ?? 5%   
   $??Email??6   $??0??6    $??3??60   ?? 5&   
   -   5        $ TextBoxMail??5&      $??0,5,0,5q?6'   $??1??68   $??3??6H   $2 ,Indicanos tu email para ponernos en contacto??6U   $
 Wrap=?6?   $
 True??6?   ??6?   ?? $
 Mail?$
 True??$
	 True??6  ?? 5(   
   $	??DNI??6   $??0??6   $??4??6.   7   1DI02_Tarea_Garcia_Hernandez_Oscar.Componentes.Dni  5)   
   -   5        
  Name$
 TBDni??5)      $??1??6)   $??4??69   6H   ?? 5+   
   $??Direccion fisica??6   $??0??6+   $??5??6;   ?? 5,   
   -   5        $ TextBoxAddress??5,      $??0,5,0,5q?6*   $??1??6;   $??5??6K   $6 0Indicanos tu direccion para ponernos en contacto??6X   $
 Wrap=?6?   $
 True??6   ??6?   ?? $ Address?$
 True??$
	 True??6  ?? 5.   
   $??Fecha de nacimiento??6   $??0??6.   $??6??6>   (  "System.Windows.Controls.DatePicker  5/   
   -   5          Name$ 
DatePicker??5/      $??0,5,0,5q?6)   $??1??6:   $??6??6J      SelectedDate 6W   ?? $ Fecha??? 51   
   $??Mayor de 18 años??6   $??0??6+   $??7??6;   ?? 52   
   -	   5         ??Name$ CheckCertificado??52      $??0,5,0,5q?6-   $??1??6>   $??7??6N   $' !Dinos si eres mayor de edad o no.??6[   $??*??6?   ?? 54   
   -
   5         ??Name$ ButtonAceptar??54      $??
20,5,-20,5q?6(   $??0??6<   $??8??6L   $N HAl aceptar, envias el contenido del formulario para completar el perfil.??6Y   $??Aceptar??6?   6?   ?? 55   
   -   5        $ ButtonCancelar??55      $??60,5,0,5q?6)   $??1??6;   $??8??6K   $> 8Cancelas la operación y vuelves a la página principal.??6X   $??Cancelar??6?   6?   56      57      