# Roadmap - World Conquest

## Fase 0 - Fundação

- [x] Criar repositório.
- [x] Criar `README.md`.
- [x] Criar `About/About.xml`.
- [x] Criar documentação de escopo.
- [ ] Criar projeto C# compilável.
- [ ] Conectar referências locais do RimWorld.

## Fase 1 - MVP Territorial

Objetivo: provar que o mapa mundial pode ter domínio por tile.

- [ ] Criar `TerritoryData`.
- [ ] Criar `WorldConquestGameComponent`.
- [ ] Salvar/carregar tiles dominados.
- [ ] Detectar assentamento principal do jogador.
- [ ] Marcar tile inicial como dominado.
- [ ] Criar comando para dominar tile vizinho.
- [ ] Impedir domínio de tile não adjacente.

## Fase 2 - Overlay Visual

Objetivo: mostrar cores no mapa mundial.

- [ ] Renderizar cor em cima dos tiles dominados.
- [ ] Usar cor da facção ou cor customizada.
- [ ] Destacar fronteiras.
- [ ] Mostrar tooltip do território.

## Fase 3 - Economia

Objetivo: transformar território em renda.

- [ ] Criar cálculo de renda diária.
- [ ] Gerar prata por tile controlado.
- [ ] Criar log de receita diária.
- [ ] Balancear renda base.
- [ ] Diferenciar renda por bioma.

## Fase 4 - Interface

Objetivo: dar controle estratégico ao jogador.

- [ ] Criar aba World Conquest.
- [ ] Mostrar territórios dominados.
- [ ] Mostrar renda diária.
- [ ] Mostrar ranking simples.
- [ ] Mostrar tiles de fronteira.

## Fase 5 - Defesa e Guerra

Objetivo: permitir disputa real.

- [ ] Criar defesa por tile.
- [ ] Criar fortificações.
- [ ] Criar declaração de guerra.
- [ ] Permitir tomada de tile inimigo.
- [ ] Criar consequências econômicas.

## Fase 6 - IA e Multiplayer

Objetivo: transformar em tabuleiro vivo.

- [ ] Facções NPC expandem.
- [ ] Eventos mundiais disputáveis.
- [ ] Ranking global persistente.
- [ ] Sincronização futura com mod multiplayer.
