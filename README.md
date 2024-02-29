# ABM Backend

Prueba técnica para CLT

Para clonar el proyecto

```bash
  git clone https://github.com/buddhapy/ABMdotNet.git
```

## Usage/Examples

Para la base de datos, utilicé la Oracle 21C Express

```javascript
CREATE TABLE PRODUCTOS (
    id NUMBER GENERATED BY DEFAULT ON NULL AS IDENTITY,
    nombre VARCHAR2(100) NOT NULL,
    codigo_producto VARCHAR2(50) UNIQUE NOT NULL,
    precio NUMBER(10,0) NOT NULL,
    CONSTRAINT productos_pk PRIMARY KEY (id)
);

CREATE TABLE CLIENTES (
    id NUMBER GENERATED BY DEFAULT ON NULL AS IDENTITY,
    nombre VARCHAR2(100) NOT NULL,
    apellido VARCHAR2(100) NOT NULL,
    email VARCHAR2(100) UNIQUE NOT NULL,
    telefono VARCHAR2(20) NOT NULL,
    direccion VARCHAR2(200),
    CONSTRAINT clientes_pk PRIMARY KEY (id)
);

CREATE TABLE Ventas (
    id NUMBER GENERATED BY DEFAULT ON NULL AS IDENTITY,
    id_cliente NUMBER NOT NULL,
    id_producto NUMBER NOT NULL,
    cantidad NUMBER NOT NULL,
    monto_pagar NUMBER(10,0) NOT NULL,
    CONSTRAINT ventas_pk PRIMARY KEY (id),
    CONSTRAINT ventas_fk_cliente FOREIGN KEY (id_cliente) REFERENCES Clientes(id),
    CONSTRAINT ventas_fk_producto FOREIGN KEY (id_producto) REFERENCES Productos(id)
);

```

e inserté datos de prueba

```javascript
INSERT INTO Productos (nombre, codigo_producto, precio) VALUES ('Camisa', 'CAM001', 29000);
INSERT INTO Productos (nombre, codigo_producto, precio) VALUES ('Pantalón', 'PAN002', 39000);
INSERT INTO Productos (nombre, codigo_producto, precio) VALUES ('Zapatos', 'ZAP003', 59000);

INSERT INTO Clientes (nombre, apellido, email, telefono, direccion) VALUES ('Juan', 'Medina', 'juan@example.com', '123-456-7890', 'Calle Principal 123');
INSERT INTO Clientes (nombre, apellido, email, telefono, direccion) VALUES ('María', 'Mendieta', 'maria@example.com', '0981123456', 'Avenida Central 456');
INSERT INTO Clientes (nombre, apellido, email, telefono, direccion) VALUES ('Carlos', 'Maidana', 'carlos@example.com', '0971232313', 'Plaza Mayor 789');

INSERT INTO Ventas (id_cliente, id_producto, cantidad, monto_pagar) VALUES (1, 1, 2, 58000);  -- Juan compra 2 camisas
INSERT INTO Ventas (id_cliente, id_producto, cantidad, monto_pagar) VALUES (2, 2, 1, 39000);  -- María compra 1 pantalón
INSERT INTO Ventas (id_cliente, id_producto, cantidad, monto_pagar) VALUES (3, 3, 1, 59000);  -- Carlos compra 1 par de zapatos
```

Dentro del archivo Connection.cs se debe modificar el String correspondiente a la conexión

```javascript
String.ConnectionString =
  "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)" +
  "(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=xe)));" +
  "User Id=LFADMIN;Password=admin;";
```

De antemano comento que el proyecto no está finalizado, casi no disponía de tiempo entonces tuve que realizarlo ignorando algunas partes importantes.
Ante cualquier consulta pueden comunicarse conmigo, con gusto responderé las dudas.
