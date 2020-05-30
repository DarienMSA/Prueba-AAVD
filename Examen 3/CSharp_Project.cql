DROP KEYSPACE IF EXISTS CSharp_Project;

CREATE KEYSPACE IF NOT EXISTS "CSharp_Project"
WITH durable_writes = true AND replication = {
	'class' : 'SimpleStrategy',
	'replication_factor' : 1
};

Use "CSharp_Project";

DROP TABLE IF EXISTS nota_compra;

CREATE TABLE nota_compra(
		idNota TIMEUUID,
		nomCliente TEXT,
		nomEmpresa TEXT,
		objetos LIST<TEXT>,
		costo LIST<DECIMAL>,
		montoFinal DECIMAL,
		fechaGenerada DATE,
		PRIMARY KEY(idNota)
	);
	