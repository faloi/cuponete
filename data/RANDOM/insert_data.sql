INSERT  INTO RANDOM.Cliente (nombre, apellido, dni, direccion, telefono, mail, fecha_nac)
        SELECT DISTINCT Cli_Nombre, Cli_Apellido, Cli_Dni, Cli_Direccion, Cli_Telefono, Cli_Mail, Cli_Fecha_Nac
        FROM gd_esquema.Maestra