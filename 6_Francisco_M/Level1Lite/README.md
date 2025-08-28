# Nivel 1 — Llave básica (Funciones + Strings)

**Contexto:** Necesitás la llave inicial para abrir el panel del ctOS.

**Objetivo:** Implementar `ValidateAccessKey(string key) -> bool`.

## Reglas
- La clave debe **empezar** por `"WD-"` (exacto).
- Luego deben venir **exactamente 6 dígitos** (`0..9`).
- La **suma** de esos 6 dígitos debe ser **múltiplo de 7**.
- No modifiques nada fuera del bloque `// TODO`.

## Casos de prueba usados por `Program.cs`
- Válida: `WD-700000`  ✅

- Inválidas: `WD-123123`, `WX-000007`, `WD-00007` (5 dígitos), `WD-abcdef` ❌

**Desbloqueo esperado:** `✔ UNLOCK → Fragmento: CT`

## Pistas
- `key.StartsWith("WD-")` y `key.Length` para chequear formato rápido.
- `char.IsDigit(c)` para validar dígitos.
- Para sumar un dígito almacenado como `char`, usar `c - '0'`.

## Errores comunes
- Aceptar menos/más de 6 dígitos.
- Permitir letras donde deberían ir dígitos.
- Olvidar verificar que la suma sea múltiplo de 7.

## Tiempo sugerido
- 10–12 minutos.

¡Abrí el panel sin disparar las alarmas! 🔓