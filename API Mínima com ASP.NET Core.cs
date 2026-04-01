// Program.cs — Etapa 3: só o modelo por enquanto
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.MapGet("/", () => "Items API v1.0 — Bem-vindo!");
app.Run();
// ─────────────────────────────────────────────
// MODELO DE DOMÍNIO
// ─────────────────────────────────────────────
record Item(int Id, string Name, DateTime CreatedAt);