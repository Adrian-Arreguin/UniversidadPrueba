-- Tabla Maestro
CREATE TABLE tb_Maestro (
    pk_maestro INT IDENTITY(1,1) PRIMARY KEY,
    nombre VARCHAR(50) NOT NULL,
    ap_paterno VARCHAR(50) NOT NULL,
    ap_materno VARCHAR(50),
    matricula_empleado VARCHAR(20) NOT NULL UNIQUE,
    fecha_ingreso DATE NOT NULL,
    email VARCHAR(100) NOT NULL UNIQUE,
    telefono VARCHAR(20)
);

-- Tabla Alumno
CREATE TABLE tb_Alumno (
    pk_alumno INT IDENTITY(1,1) PRIMARY KEY,
    nombre VARCHAR(50) NOT NULL,
    ap_paterno VARCHAR(50) NOT NULL,
    ap_materno VARCHAR(50),
    matricula_alumno VARCHAR(20) NOT NULL UNIQUE,
    fecha_ingreso DATE NOT NULL,
    email VARCHAR(100) NOT NULL UNIQUE,
    telefono VARCHAR(20)
);

-- Tabla Materia
CREATE TABLE tb_Materia (
    pk_materia INT IDENTITY(1,1) PRIMARY KEY,
    nombre_materia VARCHAR(100) NOT NULL UNIQUE
);

-- Tabla Calificaciones
CREATE TABLE tb_Calificaciones (
    pk_calificaciones INT IDENTITY(1,1) PRIMARY KEY,
    fk_maestro INT NOT NULL,
    fk_alumno INT NOT NULL,
    fk_materia INT NOT NULL,
    calificacion DECIMAL(5,2) NOT NULL CHECK (calificacion >= 0 AND calificacion <= 100), -- Rango de calificación válido
    observaciones VARCHAR(255),
    FOREIGN KEY (fk_maestro) REFERENCES tb_Maestro(pk_maestro),
    FOREIGN KEY (fk_alumno) REFERENCES tb_Alumno(pk_alumno),
    FOREIGN KEY (fk_materia) REFERENCES tb_Materia(pk_materia)
);
