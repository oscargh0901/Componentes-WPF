   M S B A M L   `   `   `  ????\  XDI02_Tarea_Garcia_Hernandez_Oscar, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullU/clr-namespace:DI02_Tarea_Garcia_Hernandez_Oscar!DI02_Tarea_Garcia_Hernandez_Oscar  5   	   2    ,DI02_Tarea_Garcia_Hernandez_Oscar.ModalCitas   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Alocal/clr-namespace:DI02_Tarea_Garcia_Hernandez_Oscar     5   	     ? Title$
  Cita??5   	   $	??332??6   $	??417??6#   .??5	      ? -   5        .+?5
   
   ?? $??Fecha??6   $??52,0,253,268q?6    $??Bottom=?66   ?? 5   
   $??Cliente??6   $??52,0,253,228q?6"   $??Bottom=?68   ?? 5   
   $??Motivo??6   $??52,0,253,188q?6!   $??Bottom=?67   ?? 5   
   $
??Mail??6   $??52,0,253,148q?6   $??Bottom=?65   ?? 5   
   $??Certificado??6   $??52,0,253,108q?6&   $??Bottom=?6<   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ 
DatePicker??5      $??152,0,102,270q?6)   $??Bottom=?6d      SelectedDate 6@   ??  ?? Path$ Fecha?6d   ?? 5   
   -   5        $??Cliente??5   ?   $??152,0,102,230q?6    ? ToolTip$$ Dinos que tipo de usuario eres??6*   $??Bottom=?6S    ?? SelectedItem 6n   ?? $ Cliente?.@?5      ?? $+ %Soy un usuario nuevo en la plataforma??6   $??Nuevo??6K   6]   ?? 5      $% Ya he frecuentado la plataforma??6   $??Cliente??6E   6Y   5      ?? 5   
   -   5        $??Motivo??5   ?   $??152,0,102,190q?6   $" Elige el motivo de tu visita??6*   $??Bottom=?6Q    ?? SelectedValuePath$ Content??6l    6?   ?? $ Motivo?.@?5      ?? $??	Revisión??6   60   ?? 5      $??Tratamiento??6   63   ?? 5      $??
Ortodoncia??6   62   ?? 5      $??Extracción??6   62   ?? 5      $??Urgencia??6   60   5      ?? 5   
   -   5         ??Name$ TextBoxMail??5      $2 ,Indicanos tu email para ponernos en contacto??6'   $??152,0,102,150q?6^    ?? TextWrapping$
 Wrap=?6u   $??Bottom=?6?   	 ?? 	IsEnabled$
	 True??6?   ??6?   ?? $
 Mail?
 ?? NotifyOnValidationError$

 True?? ?? ValidatesOnDataErrors$
 True??6  ?? 5   
   -   5         ??Name$ CheckCertificado??5      $c ]Debes confirmar que cuentas con un certificado para poder realizar la consulta correctamente.??6-   $??*??6?   $??152,0,102,115q?6?   $??Bottom=?6?   ?? 5   
   -   5         ??Name$ ButtonAceptar??5      $J DAl aceptar, envias el contenido del formulario y sales del registro.??6(   $??Aceptar??6w   $??109,0,214,54q?6?   $??Bottom=?6?   6?   ?? 5   
   -   5        $ ButtonCancelar??5      $> 8Cancelas la operación y vuelves a la página principal.??6)   $??Cancelar??6j   $??221,0,102,54q?6}   $??Bottom=?6?   6?   5      5       