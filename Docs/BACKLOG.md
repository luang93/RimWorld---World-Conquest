# Backlog - World Conquest

Lista prática de tarefas para transformar o conceito em mod jogável.

---

## Prioridade Alta

### WC-001 - Compilar DLL inicial

**Objetivo:** gerar `Assemblies/WorldConquest.dll` sem erro.

Checklist:

- [ ] Abrir `WorldConquest.csproj`.
- [ ] Ajustar caminho das DLLs do RimWorld.
- [ ] Compilar em Debug.
- [ ] Confirmar DLL em `Assemblies/`.
- [ ] Ativar mod no RimWorld.
- [ ] Ver log `[World Conquest] Mod carregado.`.

---

### WC-002 - Confirmar salvamento do GameComponent

**Objetivo:** garantir que a lista de territórios fica salva no save.

Checklist:

- [ ] Criar território por teste/debug.
- [ ] Salvar jogo.
- [ ] Fechar RimWorld.
- [ ] Reabrir save.
- [ ] Confirmar território ainda existe.

---

### WC-003 - Botão debug para conquistar tile

**Objetivo:** permitir testar conquista sem UI final.

Ideia:

- Clicar em um tile no mapa mundial.
- Exibir comando `Conquistar território`.
- Chamar `TryClaimTile(tileId, Faction.OfPlayer, "Player Colony")`.

---

### WC-004 - Validação de adjacência

**Objetivo:** impedir expansão fora da fronteira.

Regra:

```text
O tile só pode ser conquistado se for vizinho de um tile já dominado.
```

Exceção:

```text
O primeiro tile pode ser a localização da colônia principal.
```

---

## Prioridade Média

### WC-005 - Renda por bioma

**Objetivo:** fazer cada tipo de território ter valor diferente.

Exemplo:

```text
Floresta: madeira
Montanha: aço
Planície: comida
Ruínas: componentes
```

---

### WC-006 - Tela de status

**Objetivo:** criar janela simples com estatísticas.

Campos:

- Territórios dominados.
- Renda diária.
- Defesa total.
- Influência média.

---

### WC-007 - Overlay colorido

**Objetivo:** pintar o mapa mundial com as cores dos donos.

Primeira versão:

- Cor única do jogador.
- Transparência baixa.
- Sem borda avançada.

---

## Prioridade Baixa

### WC-008 - Defesa por território

Adicionar defesa em cada tile dominado.

### WC-009 - Fortificações

Criar estruturas estratégicas no mapa mundial.

### WC-010 - Guerra

Permitir atacar e tomar tile inimigo.

### WC-011 - Diplomacia

Criar estados de relação entre impérios.

### WC-012 - Ranking mundial

Mostrar as maiores potências por número de tiles e renda.
