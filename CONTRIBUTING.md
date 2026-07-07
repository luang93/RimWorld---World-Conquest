# Como contribuir

Obrigado por considerar contribuir com o **World Conquest**.

## Objetivo do projeto

Criar um mod de estratégia global para RimWorld, onde o mapa mundial funciona como um tabuleiro de domínio territorial.

## Antes de contribuir

Leia:

- `README.md`
- `Docs/SCOPE.md`
- `Docs/ROADMAP.md`
- `Docs/ARCHITECTURE.md`
- `Docs/BACKLOG.md`

## Padrão de código

- Código em C#.
- Namespace principal: `WorldConquest`.
- Nomes claros e diretos.
- Evitar sistemas gigantes em uma única classe.
- Separar lógica por responsabilidade.

## Prioridade atual

O projeto está na fase de MVP.

Prioridade máxima:

1. Compilar DLL.
2. Salvar/carregar territórios.
3. Conquistar tile por botão/debug.
4. Validar adjacência.
5. Renderizar overlay colorido no mapa mundial.

## Commits

Use mensagens simples e objetivas:

```text
Add territory data model
Add daily income system
Fix save loading for territories
Create world map claim command
```

## Filosofia

Primeiro fazer funcionar de forma simples.
Depois melhorar visual, balanceamento e profundidade.
