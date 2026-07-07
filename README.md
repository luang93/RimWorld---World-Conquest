# 🌍 RimWorld - World Conquest

> **Transforme o mapa mundial do RimWorld em um tabuleiro estratégico de conquista, economia, guerra e domínio territorial.**

**World Conquest** é um mod de estratégia global para RimWorld inspirado em jogos como **War/Risk**, **Civilization**, **Crusader Kings** e **Hearts of Iron**, mas adaptado para a lógica de colônias, caravanas, facções e sobrevivência do RimWorld.

A ideia central é simples e poderosa: cada colônia controla territórios no mapa mundial. Esses territórios aparecem com a cor da cidade/facção, geram renda diária e podem ser disputados por outros grupos.

---

## 🎯 Visão do projeto

No RimWorld vanilla, o mapa mundial serve principalmente para caravanas, eventos e assentamentos.

No **World Conquest**, o mapa mundial vira um verdadeiro **tabuleiro vivo**:

- Cada tile pode ter um dono.
- Cada cidade possui uma cor de domínio.
- A expansão acontece pelas fronteiras.
- Territórios geram prata e recursos.
- Facções podem disputar regiões estratégicas.
- A colônia deixa de ser apenas uma base e passa a ser o centro de um império.

---

## 🧠 Fantasia do jogador

Você começa com uma pequena colônia isolada.

Com o tempo, ela cresce, domina tiles vizinhos, cria fronteiras, gera renda, fortalece posições e disputa recursos raros no planeta.

O jogador passa a pensar como líder de uma nação:

```text
Onde expandir?
Qual fronteira defender?
Qual território vale mais?
Ataco agora ou acumulo recursos?
Faço aliança ou entro em guerra?
```

---

## 🔁 Loop principal

```text
Criar colônia
↓
Expandir para tiles vizinhos
↓
Dominar território
↓
Gerar renda diária
↓
Investir em defesa e logística
↓
Disputar recursos especiais
↓
Entrar em guerra ou fazer alianças
↓
Virar potência mundial
```

---

## 🧩 MVP inicial

A primeira versão deve provar o núcleo do mod sem tentar resolver tudo de uma vez.

### Objetivo do MVP

Criar um sistema funcional onde o jogador consiga dominar tiles no mapa mundial e receber renda diária por eles.

### Funcionalidades do MVP

- Registrar dono de cada tile.
- Salvar e carregar os territórios no save.
- Permitir conquista de tile neutro.
- Validar expansão por adjacência.
- Gerar renda diária em prata.
- Exibir mensagem de receita diária.
- Preparar base para overlay colorido no mapa mundial.

---

## 🗺️ Sistema de territórios

Cada tile dominado possui dados próprios:

```text
Tile ID
Dono
Facção
Influência
Defesa
Renda diária
```

Exemplo visual conceitual:

```text
🟥🟥🟥⬜⬜
🟥🏙️🟥⬜⬜
🟥🟥🟥🟦🟦
⬜⬜🟦🏙️🟦
```

- 🟥 Cidade Alpha
- 🟦 Cidade Bravo
- ⬜ Território neutro

---

## 💰 Economia territorial

Regra inicial do MVP:

```text
Cada tile dominado gera +10 prata por dia.
```

Exemplo:

```text
25 tiles dominados = 250 prata/dia
```

Futuramente, cada bioma ou ponto estratégico poderá gerar recursos diferentes:

| Tipo de território | Recurso possível |
|---|---:|
| Planície | Comida |
| Floresta | Madeira |
| Montanha | Aço |
| Ruína antiga | Componentes |
| Área vulcânica | Urânio |
| Campo especial | Prata extra |

---

## ⚔️ Sistemas planejados

### Domínio territorial

Tiles podem ser neutros, aliados, inimigos ou controlados pelo jogador.

### Fronteiras

A expansão só deve acontecer em tiles conectados ao território existente.

### Defesa

Territórios poderão receber estruturas como:

- Posto militar
- Torre de vigia
- Radar
- Bunker
- Base avançada

### Guerra

Facções poderão disputar tiles dominados, roubando fronteiras e reduzindo a renda do inimigo.

### Diplomacia

Sistema futuro de relações:

- Neutro
- Aliado
- Guerra
- Vassalo
- Protegido

### Eventos globais

Eventos que aparecem no mundo e incentivam disputa:

- Mina rara descoberta
- Ruínas tecnológicas
- Base pirata
- Meteorito valioso
- Infestação em região rica
- Depósito militar abandonado

---

## 🏗️ Estrutura atual

```text
RimWorld---World-Conquest/
├── About/
│   └── About.xml
├── Assemblies/
├── Defs/
├── Docs/
│   ├── ARCHITECTURE.md
│   ├── DEV_NOTES.md
│   ├── ROADMAP.md
│   └── SCOPE.md
├── Languages/
├── Source/
│   └── WorldConquest/
│       ├── TerritoryData.cs
│       ├── WorldConquest.csproj
│       ├── WorldConquestGameComponent.cs
│       └── WorldConquestMod.cs
└── Textures/
```

---

## 🧱 Código inicial

O projeto já possui uma base em C#:

### `TerritoryData`

Modelo de dados para representar um território dominado.

### `WorldConquestGameComponent`

Componente global responsável por:

- manter a lista de territórios;
- salvar/carregar dados;
- conquistar tile;
- gerar renda diária;
- enviar mensagem ao jogador.

### `WorldConquestMod`

Entrada básica do mod.

---

## 🚀 Roadmap resumido

### Fase 0 - Fundação

- [x] Criar estrutura do mod.
- [x] Criar documentação inicial.
- [x] Criar modelo `TerritoryData`.
- [x] Criar `WorldConquestGameComponent`.
- [ ] Compilar DLL localmente.

### Fase 1 - MVP territorial

- [ ] Marcar tile inicial do jogador.
- [ ] Criar botão de conquistar tile.
- [ ] Validar adjacência.
- [ ] Salvar domínio no save.
- [ ] Gerar renda diária funcional.

### Fase 2 - Visual no mapa

- [ ] Criar overlay colorido.
- [ ] Pintar tiles dominados.
- [ ] Mostrar tooltip de território.
- [ ] Destacar fronteiras.

### Fase 3 - Estratégia

- [ ] Recursos por bioma.
- [ ] Defesa por tile.
- [ ] Ranking mundial.
- [ ] Eventos globais.

### Fase 4 - Guerra e diplomacia

- [ ] Declaração de guerra.
- [ ] Ataque a tiles inimigos.
- [ ] Alianças.
- [ ] Facções NPC expandindo.

---

## 🛠️ Como compilar

O projeto C# está em:

```text
Source/WorldConquest/WorldConquest.csproj
```

Antes de compilar, ajuste no `.csproj` os caminhos das DLLs do RimWorld para a pasta correta do seu PC.

Caminho comum na Steam:

```text
C:/Program Files (x86)/Steam/steamapps/common/RimWorld/RimWorldWin64_Data/Managed/
```

Arquivos principais:

```text
Assembly-CSharp.dll
UnityEngine.CoreModule.dll
UnityEngine.IMGUIModule.dll
```

A DLL final deve ser gerada em:

```text
Assemblies/WorldConquest.dll
```

---

## 📌 Status atual

**Status:** Fundação técnica criada.  
**Próximo objetivo:** botão de debug no mapa mundial para conquistar tile e testar salvamento/renda.

---

## 🧭 Filosofia de desenvolvimento

Este mod deve crescer por camadas.

Primeiro, o domínio territorial precisa funcionar de forma simples. Depois entram visual, economia avançada, guerra, diplomacia e multiplayer.

A prioridade é criar um núcleo sólido antes de adicionar sistemas grandes.

---

## 👑 Autor

Criado por **Guimma**.

Projeto pensado para transformar RimWorld em uma experiência de estratégia global persistente.